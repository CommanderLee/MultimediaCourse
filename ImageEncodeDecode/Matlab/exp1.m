% Image Encoding and Decoding - Zhen Li, Tsinghua University

% Load Image
myImg = imread('lena.bmp');
imshow(myImg);

% Convert to Gray-Scale
myImgGray = rgb2gray(myImg);
figure;
imshow(myImgGray);