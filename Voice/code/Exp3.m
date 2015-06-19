% Voice - Zhen Li, Tsinghua University

gdgOri = '..\data\实验1\guodegang.wav';
gdgChg1 = '..\data\实验1-output\gdg01-F0_3.wav';
gdgChg2 = '..\data\实验1-output\gdg02-frequency_2.wav';
gdgChg3 = '..\data\实验1-output\gdg03-temporal_1_3.wav';
gdgFile = {gdgChg1, gdgChg2, gdgChg3};

stfOri = '..\data\实验1\shantianfang.wav';
stfChg1 = '..\data\实验1-output\stf01-f0_0_33.wav';
stfChg2 = '..\data\实验1-output\stf02-frequency_0_49.wav';
stfChg3 = '..\data\实验1-output\stf03-temporal_0_34.wav';
stfFile = {stfChg1, stfChg2, stfChg3};

a6000 = '..\data\实验2\A\sen6000.wav';
a6015 = '..\data\实验2\A\sen6015.wav';
a6028 = '..\data\实验2\A\sen6028.wav';
a6044 = '..\data\实验2\A\sen6044.wav';
a6147 = '..\data\实验2\A\sen6147.wav';
aFile = {a6000, a6015, a6028, a6044, a6147};

b6000 = '..\data\实验2\B\sen6000.wav';
b6015 = '..\data\实验2\B\sen6015.wav';
b6028 = '..\data\实验2\B\sen6028.wav';
b6044 = '..\data\实验2\B\sen6044.wav';
b6147 = '..\data\实验2\B\sen6147.wav';
bFile = {b6000 b6015 b6028 b6044 b6147};

% c: a-changed
c6000 = '..\data\实验2-output\A-sen6000-changed.wav';
c6015 = '..\data\实验2-output\A-sen6015-changed.wav';
c6028 = '..\data\实验2-output\A-sen6028-changed.wav';
c6044 = '..\data\实验2-output\A-sen6044-changed.wav';
c6147 = '..\data\实验2-output\A-sen6147-changed.wav';
cFile = {c6000 c6015 c6028 c6044 c6147};

for i=1:3

    [src, fsSrc] = audioread(stfOri);
    [dst, fsDst] = audioread(char(stfFile(i)));
%     [src, fsSrc] = audioread(char(aFile(i)));
%     [dst, fsDst] = audioread(char(cFile(i)));

    result = getDistance2(src, fsSrc, dst, fsDst);
    fprintf('Distance#2 of %s and %s: %f\n', char(aFile(i)), char(bFile(i)), result);
    
end




