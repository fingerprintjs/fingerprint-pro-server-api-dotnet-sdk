import config from '../config.json' assert {type: 'json'};
import path from 'path';
import fs from 'fs'
import cp from 'child_process'

const dirname = import.meta.url.replace(/^file:\/\//, '');

function getVersion() {
    const version = process.env.NEW_VERSION;

    if (!version) {
        throw new Error('NEW_VERSION environment variable is not set');
    }

    console.info('New version:', version);

    return version;
}

function bumpConfigVersion(version) {
    const configPath = path.resolve(dirname, '../../config.json');

    console.info('Config path:', configPath);

    config.packageVersion = version;

    fs.writeFileSync(configPath, JSON.stringify(config, null, 4));
}

function bumpCsprojVersion(version) {
    const csprojPath = path.resolve(dirname, '../../src/Fingerprint.ServerSdk/Fingerprint.ServerSdk.csproj');

    console.info('Csproj path:', csprojPath);

    const csproj = fs.readFileSync(csprojPath, 'utf8');

    // Replace <Version> tag with given version
    const newCsproj = csproj.replace(/<Version>.*<\/Version>/, `<Version>${version}</Version>`);

    fs.writeFileSync(csprojPath, newCsproj);
}

function generateSwaggerCode() {
    cp.execSync(`sh ${path.resolve(dirname, '../../generate.sh')}`, {
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
