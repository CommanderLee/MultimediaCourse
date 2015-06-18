% Image Encoding and Decoding - Zhen Li, Tsinghua University

% Load Image
myImg = im2double(imread('lena.bmp'));
% imshow(myImg);

% Convert to Gray-Scale
myImgGray = rgb2gray(myImg);
figure, imshow(myImgGray);
imwrite(myImgGray, 'lena_gray.bmp');

[row, col] = size(myImgGray);
tic;
% 1-D DCT. First Row Then Column. Whole Img
imgDCTWhole = zeros(row, col);
for r=1:row
    imgDCTWhole(r,:) = dct(double(myImgGray(r,:)));
end 
toc;
% figure, imshow(imgDCTWhole);
imgIDCTWhole = zeros(row, col);

% IDCT. Whole Img.
for r=1:row
    imgIDCTWhole(r,:) = idct(imgDCTWhole(r,:));
end 
% figure, imshow(imgIDCTWhole);

% 2-D DCT.
tic;
imgDCT2Whole = dct2(myImgGray);
toc;
imgIDCT2Whole = idct2(imgDCT2Whole);
% figure, imshow(imgIDCT2Whole);

% 8*8 DCT
tic;
nSize = 2;
dctMtx = dctmtx(nSize);
dctMtx_ = dctMtx';
funDct = @(block_struct) dctMtx * block_struct.data * dctMtx_;
imgDCT8 = blockproc(myImgGray, [nSize nSize], funDct);
toc;

funIDct = @(block_struct) dctMtx_ * block_struct.data * dctMtx;
imgIDCT8 = blockproc(imgDCT8, [nSize nSize], funIDct);
figure, imshow(imgIDCT8);
