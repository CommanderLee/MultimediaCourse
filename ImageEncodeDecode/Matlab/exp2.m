% Image Encoding and Decoding - Zhen Li, Tsinghua University

% Load Image
% myImg = im2double(imread('lena.bmp'));
myImg = imread('lena.bmp');
% imshow(myImg);

% Convert to Gray-Scale
myImgGray = rgb2gray(myImg);
figure, imshow(myImgGray);
imwrite(myImgGray, 'lena_gray.bmp');

[row, col] = size(myImgGray);

nSize = 8;
dctMtx = dctmtx(nSize);
dctMtx_ = dctMtx';
funDct = @(block_struct) dctMtx * block_struct.data * dctMtx_;
imgDCTN = blockproc(myImgGray, [nSize nSize], funDct);

% funIDctQ = @(block_struct) dctMtx_ * block_struct.data * dctMtx;
imgIDCTN = blockproc(imgDCTN, [nSize nSize], funIDctQ);
figure, imshow(imgIDCTN);

MSE = getMSE(myImgGray, imgIDCTN);
PSNR = 10 * log10(255^2 / MSE);

