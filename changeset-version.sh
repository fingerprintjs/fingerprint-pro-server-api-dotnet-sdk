#!/usr/bin/env bash
pnpm exec changeset version && node bumpConfig.mjs && bash ./generate.sh
