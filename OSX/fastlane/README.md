fastlane documentation
----

# Installation

Make sure you have the latest version of the Xcode command line tools installed:

```sh
xcode-select --install
```

For _fastlane_ installation instructions, see [Installing _fastlane_](https://docs.fastlane.tools/#installing-fastlane)

# Available Actions

## Mac

### mac release

```sh
[bundle exec] fastlane mac release
```

Build, and create a DMG file

### mac test

```sh
[bundle exec] fastlane mac test
```



### mac build

```sh
[bundle exec] fastlane mac build
```

Build the IOS Application

### mac prepare_signing

```sh
[bundle exec] fastlane mac prepare_signing
```

Installs signing certificate in the keychain

### mac remove_keychain

```sh
[bundle exec] fastlane mac remove_keychain
```

Delete keychain

----

This README.md is auto-generated and will be re-generated every time [_fastlane_](https://fastlane.tools) is run.

More information about _fastlane_ can be found on [fastlane.tools](https://fastlane.tools).

The documentation of _fastlane_ can be found on [docs.fastlane.tools](https://docs.fastlane.tools).
