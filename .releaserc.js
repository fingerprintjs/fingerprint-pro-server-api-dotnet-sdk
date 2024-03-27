module.exports = {
  "branches": [
    "main",
    {
      "name": "test",
      "prerelease": true
    }
  ],
  "plugins": [
    [
      "@semantic-release/commit-analyzer",
      {
        "config": "@fingerprintjs/conventional-changelog-dx-team",
        "releaseRules": "@fingerprintjs/conventional-changelog-dx-team/release-rules"
      }
    ],
    [
      "@semantic-release/release-notes-generator",
      {
        "config": "@fingerprintjs/conventional-changelog-dx-team",
      }
    ],
    [
      "@semantic-release/changelog",
      {
        "changelogFile": "CHANGELOG.md"
      }
    ],
    [
      "@semantic-release/exec",
      {
        "prepareCmd": "NEW_VERSION=\"${nextRelease.version}\" node bumpConfigAndGenerate.mjs && NEW_VERSION=\"${nextRelease.version}\" node publish.mjs"
      }
    ],
    [
      "@semantic-release/git",
      {
        "assets": [
          "CHANGELOG.md",
          "config.json",
          "README.md",
          "config.json",
          "docs/**/*",
          "src/FingerprintPro.ServerSdk/FingerprintPro.ServerSdk.csproj",
          "src/**/Api/*.cs",
          "src/**/Model/*.cs",
          "src/**/Client/*.cs",
        ]
      }
    ],
    "@semantic-release/github"
  ]
}