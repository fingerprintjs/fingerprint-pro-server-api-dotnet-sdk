import cp from 'child_process';
import * as path from "path";

const dirname = import.meta.url.replace(/^file:\/\//, '');

const version = process.env.NEW_VERSION;
const apiKey = process.env.NUGET_API_KEY;

if (!version) {
    throw new Error('NEW_VERSION environment variable is not set');
}

if (!apiKey) {
    throw new Error('NUGET_API_KEY environment variable is not set');
}

console.info('New version:', version);
console.info('Building library...');

cp.execSync('dotnet build --configuration Release --no-restore', {
    stdio: 'inherit'
})

const fileName = `Fingerprint.Sdk.${version}.nupkg`;

console.info(`Publishing ${fileName}...`);

cp.execSync(`dotnet nuget push ${fileName} --api-key ${apiKey} --source https://api.nuget.org/v3/index.json`, {
    stdio: 'inherit',
    cwd: path.resolve(dirname, '../src/Fingerprint.Sdk/bin/Release')
})