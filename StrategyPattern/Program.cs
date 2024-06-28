
using StrategyPattern;

Compressor compressor = new Compressor(new ZIPCompression());
compressor.Compress("file.txt");

compressor =  new Compressor(new RARCompression());
compressor.Compress("file.txt");