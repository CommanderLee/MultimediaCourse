% Image Encoding and Decoding - Zhen Li, Tsinghua University
% Mean Squared Error

function result = getMSE(mat1, mat2)
    [r, c] = size(mat1);
    [r2, c2] = size(mat2);
    if r == r2 && c == c2
        mat3 = mat1 - mat2;
        result = sum(sum(mat3 .* mat3));
        result = double(result) / (r * c);
    else
        print('Error. Size Not Match');
        result = -1;
    end
end