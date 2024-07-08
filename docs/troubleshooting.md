## Err

failed to solve: ubuntu:22.04: error getting credentials - err: fork/exec /usr/bin/docker-credential-desktop.exe: exec format error, out: `:

- rm -rf ~/.password-store/docker-credential-helpers
- https://stackoverflow.com/a/74413229

```bash
# Go to config:
sudo vi ~/.docker/config.json
# Rename credsStore to credStore and save.
```
