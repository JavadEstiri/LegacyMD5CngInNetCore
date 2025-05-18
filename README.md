# LegacyMD5CngInNetCore

🛠️ MD5Cng for .NET Core/5+ (Linux/macOS)

*A cross-platform workaround to generate MD5 hashes using CNG-like behavior in modern .NET non-Windows environments.*


🚀 Why This Exists

Microsoft removed MD5Cng from .NET Core/5+ and restricted it to Windows-only frameworks. This library fills the gap, enabling legacy systems or niche workflows (e.g., FIPS-compliant toolchains, backward-compatible integrations) to use MD5Cng-style hashing on Linux, macOS, and Docker with .NET 6/7/8.


💡 Key Features

✅ Cross-Platform MD5Cng Emulation: Mimic the deprecated MD5Cng API on non-Windows systems.

✅ CNG-like Behavior: Uses platform-native cryptography libraries (e.g., OpenSSL) under the hood.

✅ No Windows Dependencies: Works seamlessly in Linux/macOS CI/CD pipelines or containers.

✅ Legacy Compatibility: Migrate old .NET Framework codebases to modern .NET without rewriting hashing logic.


📜 Use Cases

Migrate enterprise apps relying on MD5Cng to .NET 8.

Maintain compatibility with legacy systems that require MD5 (e.g., checksums for non-security-critical tasks).

Debug/test FIPS-mode workflows in cross-platform environments.


⚠️ Caveats

MD5 is Insecure: Only use this for non-cryptographic purposes (e.g., checksums, legacy integrations).
Not FIPS-Compliant: Mimics MD5Cng’s behavior but does not enforce FIPS rules.
