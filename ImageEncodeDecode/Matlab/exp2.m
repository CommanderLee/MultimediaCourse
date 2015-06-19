% Image Encoding and Decoding - Zhen Li, Tsinghua University

% Load Image
myImg = im2double(imread('lena.bmp'));
% myImg = im2double(imread('COL.png'));
% myImg = imread('lena.bmp');
% imshow(myImg);

% Convert to Gray-Scale
% myImgGray = double(rgb2gray(myImg));
myImgGray = rgb2gray(myImg);
% figure, imshow(myImgGray);
imwrite(myImgGray, 'lena_gray.bmp');
% imwrite(myImgGray, 'COL_gray.png');

[row, col] = size(myImgGray);

nSize = 8;
dctMtx = dctmtx(nSize);

jpegQ = [16 11 10 16 24 40 51 61
12 12 14 19 26 58 60 55
14 13 16 24 40 57 69 56
14 17 22 29 51 87 80 62
18 22 37 56 68 109 103 77
24 35 55 64 81 104 113 92
649 64 78 87 103 121 120 101
72 92 95 98 112 100 103 99];

canonQ = [1 1 1 2 3 6 8 10
    1 1 2 3 4 8 9 8
    2 2 2 3 6 8 10 8
    2 2 3 4 7 12 11 9
    3 3 8 11 10 16 15 11
    3 5 8 10 12 15 16 13
    7 10 11 12 15 17 17 14
    14 13 13 15 15 14 14 14];

nikonQ = [2 1 1 2 3 5 6 7
    1 1 2 2 3 7 7 7
    2 2 2 3 5 7 8 7
    2 2 3 3 6 10 10 7
    2 3 4 7 8 13 12 9
    3 4 7 8 10 12 14 11
    6 8 9 10 12 15 14 12
    9 11 11 12 13 12 12 12];

% qMat = nikonQ;

plotA = 0.1:0.05:2;
plotPSNR = zeros(size(plotA, 1));
plotIndex = 1;
for a=plotA
    qMat = jpegQ .* a;
    
    imgDCTNQ = zeros(row, col);
    for r=1:8:row
        for c=1:8:col
            resultMat = dctMtx * (myImgGray(r:r+7,c:c+7) .* 255) * dctMtx';
            imgDCTNQ(r:r+7,c:c+7) = round(resultMat ./ qMat);
        end
    end

    % imgDCTNQ = blockproc(myImgGray, [nSize nSize], @funDctQ);
    % dctMtx_ = dctMtx';
    % funDct = @(block_struct) dctMtx * block_struct.data * dctMtx_;
    % imgDCTN = blockproc(myImgGray, [nSize nSize], funDct);

    % funIDctQ = @(block_struct) dctMtx' * block_struct.data * dctMtx;
    % imgIDCTN = blockproc(imgDCTNQ, [nSize nSize], funIDctQ);
    PSNRList = zeros(1, (row/8) * (col/8));
    PSNRIndex = 1;
    imgIDCTNQ = zeros(row, col);
    for r=1:8:row
        for c=1:8:col
            resultMat = dctMtx' * (imgDCTNQ(r:r+7,c:c+7) .* qMat) * dctMtx;
            imgIDCTNQ(r:r+7,c:c+7) = (resultMat) / 255.0;
            MSE = getMSE(myImgGray(r:r+7,c:c+7), imgIDCTNQ(r:r+7,c:c+7));
            PSNRList(PSNRIndex) = 10 * log10(255^2 / MSE);
            PSNRIndex = PSNRIndex + 1;
        end
    end
    meanPSNR = mean(PSNRList);
    fprintf('PSNR Mean:%f\n', meanPSNR);
    plotPSNR(plotIndex) = meanPSNR;
    plotIndex = plotIndex + 1;
%     figure, imshow(imgIDCTNQ);

    MSE = getMSE(myImgGray, imgIDCTNQ);
    PSNR = 10 * log10(255^2 / MSE);
    fprintf('8*8: 2D-MSE:%f, PSNR:%f\n', MSE, PSNR);
end
figure, plot(plotA, plotPSNR);