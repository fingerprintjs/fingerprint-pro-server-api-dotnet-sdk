import config from '../config.json' assert {type: 'json'};
import path from 'path';
import fs from 'fs'
import cp from 'child_process'

const dirname = import.meta.url.replace(/^file:\/\//, '');

const version = process.env.NEW_VERSION;

if (!version) {
    throw new Error('NEW_VERSION environment variable is not set');
}

console.info('New version:', version);

config.packageVersion = version;

fs.writeFileSync(path.resolve(dirname, '../config.json'), JSON.stringify(config, null, 4));

cp.execSync(`sh ${path.resolve(dirname, '../generate.sh')}`, {
    stdio: 'inherit'
});