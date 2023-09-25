import config from './config.json' assert {type: 'json'};
import fs from 'fs'
import cp from 'child_process'
import { fileURLToPath } from 'url';
import path from 'path';

const filename = fileURLToPath(import.meta.url);
const dirname = path.dirname(filename);

console.info('dirname', dirname);

const paths = {
    config: path.resolve(dirname, './config.json'),
    csproj: path.resolve(dirname, './src/FingerprintPro.ServerSdk/FingerprintPro.ServerSdk.csproj'),
}

console.info('paths', paths);

function getVersion() {
    const version = process.env.NEW_VERSION;

    if (!version) {
        throw new Error('NEW_VERSION environment variable is not set');
    }

    console.info('New version:', version);

    return version;
}

function bumpConfigVersion(version) {
    config.packageVersion = version;

    fs.writeFileSync(paths.config, JSON.stringify(config, null, 4));
}

function bumpCsprojVersion(version) {
    const csproj = fs.readFileSync(paths.csproj, 'utf8');

    // Replace <Version> tag with given version
    const newCsproj = csproj.replace(/<Version>.*<\/Version>/, `<Version>${version}</Version>`);
    
    console.info('newCsproj', newCsproj);

    fs.writeFileSync(paths.csproj, newCsproj);
}

function generateSwaggerCode() {
    cp.execSync(`sh ${path.resolve(dirname, 'generate.sh')}`, {
        stdio: 'inherit'
    });
}

function main() {
    const version = getVersion();

    bumpConfigVersion(version);
    bumpCsprojVersion(version);
    generateSwaggerCode();
}

main();
