% Image Encoding and Decoding - Zhen Li, Tsinghua University

% Load Image
myImg = im2double(imread('lena.bmp'));
% myImg = imread('lena.bmp');
% imshow(myImg);

% Convert to Gray-Scale
myImgGray = rgb2gray(myImg);
% figure, imshow(myImgGray);
imwrite(myImgGray, 'lena_gray.bmp');

[row, col] = size(myImgGray);

% 1-D DCT. First Row Then Column. Whole Img
imgDCT1D = zeros(row, col);

tic;
keepCol = col / 16;
markMat1D = [ ones(1, keepCol) zeros(1, col - keepCol) ];
for r=1:row
    imgDCT1D(r,:) = dct(myImgGray(r,:)) .* markMat1D;
end 
toc;
% figure, imshow(imgDCT1D);

% IDCT. Whole Img.
imgIDCT1D = zeros(row, col);
for r=1:row
    imgIDCT1D(r,:) = idct(imgDCT1D(r,:));
end 
% figure, imshow(imgIDCT1D);

MSE = getMSE(myImgGray, imgIDCT1D);
PSNR = 10 * log10(255^2 / MSE);
fprintf('1D-Keep %d coef: MSE:%f, PSNR:%f\n', keepCol, MSE, PSNR);

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% 2-D DCT.
tic;
% Keep [keepNum] DCT coef on the top-left corner of the DCT Matrix
keepNum = row * col / 64;
% The triangle on the top-left corner
triangleLen = floor(sqrt(keepNum * 2)) - 1;
onesRemain = keepNum - triangleLen * (triangleLen + 1) / 2;
fprintf('Triangle Len:%d, ones remain:%d\n', triangleLen, onesRemain);
markMat2D = zeros(row, col);
% Marking the top-left corner of Mark Matrix
for r=1:onesRemain
    markMat2D(r, 1:triangleLen+1) = ones(1, triangleLen+1);
    triangleLen = triangleLen - 1;
end
for r=(onesRemain+1):row
    markMat2D(r, 1:triangleLen) = ones(1, triangleLen);
    triangleLen = triangleLen - 1;
end

imgDCT2D = dct2(myImgGray) .* markMat2D;
toc;
imgIDCT2D = idct2(imgDCT2D);
figure, imshow(imgIDCT2D);

MSE = getMSE(myImgGray, imgIDCT2D);
PSNR = 10 * log10(255^2 / MSE);
fprintf('2D-Keep %d coef: MSE:%f, PSNR:%f\n', keepNum, MSE, PSNR);

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% 8*8 DCT
tic;
nSize = 8;
dctMtx = dctmtx(nSize);
dctMtx_ = dctMtx';
funDct = @(block_struct) dctMtx * double(block_struct.data) * dctMtx_;
imgDCTN = blockproc(myImgGray, [nSize nSize], funDct);
toc;

% funIDct = @(block_struct) dctMtx_ * block_struct.data * dctMtx;
% imgIDCTN = blockproc(imgDCTN, [nSize nSize], funIDct);
% figure, imshow(imgIDCTN);

% MSE = getMSE(myImgGray, imgIDCTN);
% PSNR = 10 * log10(255^2 / MSE);
% fprintf('8*8: MSE:%f, PSNR:%f\n', MSE, PSNR);
