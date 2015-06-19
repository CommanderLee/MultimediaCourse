function result = getHistogram(data)
    % histogram: 10~500.
    [row len] = size(data);
    result = zeros(1, 50);
    for i=1:len
        dataBin = floor(data(i) / 10);
%         fprintf('%d\n', dataBin);
        if dataBin >= 1 && dataBin <= 50
            result(dataBin) = result(dataBin) + 1;
        end
    end
    result = result ./ sum(result);
end