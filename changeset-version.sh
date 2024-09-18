#!/usr/bin/env bash
pnpm exec changeset version && node bumpConfigAndGenerate.mjs
