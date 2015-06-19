function result = getDistance1(src, fsSrc, dst, fsDst)
    [f0rawSrc, apSrc] = exstraightsource(src, fsSrc);
    [f0rawDst, apDst] = exstraightsource(dst, fsDst);

    result = abs(mean(f0rawSrc) - mean(f0rawDst));
end