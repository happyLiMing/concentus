# Concentus: Opus for Everyone

This project is an effort to port the Opus reference library to work natively in other languages, and to gather together any such ports that may exist. With this code, developers should be left with no excuse to use an inferior codec, regardless of their language or runtime environment.

## Project Status

This repo contains a completely functional Opus implementation in portable C#. It it based on libopus master 1.1.2 configured with FIXED_POINT and (optionally) DISABLE_FLOAT_API. Both the encoder and decoder paths have been thoroughly tested to be bit-exact with their equivalent C functions in all common use cases.

Performance-wise, the current build runs about 40-50% as fast as its equivalent libopus build, with some room for further improvement. At this point the API surface is fairly finalized (except for the repacketizer), so future optimizations should not affect build configuration.

In the future I plan to make a Java version as well, but I will wait until the current C# base is relatively optimized and can carry those improvements to another language. Other ports stemming from the C# base are welcome from any contributors.
