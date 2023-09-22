import cp from 'child_process';
import * as path from "path";
import * as fs from "fs";

const dirname = import.meta.url.replace(/^file:\/\//, '');
const sdkPath = path.resolve(dirname, 'src/FingerprintPro.ServerSdk');

const paths = {
    sdk: sdkPath,
    release: path.join(sdkPath, 'bin/Release')
}

Object.entries(paths).forEach(([key, value]) => {
    if (!fs.existsSync(value)) {
        throw new Error(`Path ${key} does not exist: ${value}`);
    }
})

console.info('Publishing SDK to NuGet',);
console.info('Paths:', paths);

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
    stdio: 'inherit',
    cwd: paths.sdk
})

console.info('Packing library...');

cp.execSync('dotnet pack --configuration Release --no-restore', {
    stdio: 'inherit',
    cwd: paths.sdk
})

const fileName = `FingerprintPro.ServerSdk.${version}.nupkg`;

console.info(`Publishing ${fileName}...`);

cp.execSync(`dotnet nuget push ${fileName} --api-key ${apiKey} --source https://api.nuget.org/v3/index.json`, {
    stdio: 'inherit',
    cwd: paths.release
})