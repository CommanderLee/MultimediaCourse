function result = getDistance2(src, fsSrc, dst, fsDst)
    [f0rawSrc, apSrc] = exstraightsource(src, fsSrc);
    [f0rawDst, apDst] = exstraightsource(dst, fsDst);
    
%     figure, plot(f0rawSrc);
    histoSrc = getHistogram(f0rawSrc);
    histoDst = getHistogram(f0rawDst);
    [row len] = size(histoSrc);
    histoDistance = histoSrc - histoDst;
    
    result = sum(histoDistance .* histoDistance) / len;
end