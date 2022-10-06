//Discovering novel algorithms with AlphaTensor
//https://www.deepmind.com/blog/discovering-novel-algorithms-with-alphatensor?utm_campaign=AlphaTensor&utm_medium=bitly&utm_source=Twitter+Organic

RecognitionResultOfHumanOCR();


unsafe void RecognitionResultOfHumanOCR ()
{
    float* h = stackalloc float[77];
    float* a = stackalloc float[25];
    float* b = stackalloc float[25];
    float* c = stackalloc float[25];



    h[1] = a[(3 - 1) * 5 + (2 - 1)] * (-b[(2 - 1) * 5 + (1 - 1)] - b[(2 - 1) * 5 + (5 - 1)] - b[(3 - 1) * 5 + (1 - 1)]);
    h[2] = (a[(2 - 1) * 5 + (2 - 1)] + a[(2 - 1) * 5 + (5 - 1)] - a[(3 - 1) * 5 + (5 - 1)]) * (-b[(2 - 1) * 5 + (5 - 1)] - b[(5 - 1) * 5 + (1 - 1)]);
    h[3] = (-a[(3 - 1) * 5 + (1 - 1)] - a[(4 - 1) * 5 + (1 - 1)] + a[(4 - 1) * 5 + (2 - 1)]) * (-b[(1 - 1) * 5 + (1 - 1)] + b[(2 - 1) * 5 + (5 - 1)]);
    h[4] = (a[(1 - 1) * 5 + (2 - 1)] + a[(1 - 1) * 5 + (4 - 1)] + a[(3 - 1) * 5 + (4 - 1)]) * (-b[(2 - 1) * 5 + (5 - 1)] - b[(4 - 1) * 5 + (1 - 1)]);
    h[5] = (a[(1 - 1) * 5 + (5 - 1)] + a[(2 - 1) * 5 + (2 - 1)] + a[(2 - 1) * 5 + (5 - 1)]) * (-b[(2 - 1) * 5 + (4 - 1)] + b[(5 - 1) * 5 + (1 - 1)]);
    h[6] = (-a[(2 - 1) * 5 + (2 - 1)] - a[(2 - 1) * 5 + (5 - 1)] - a[(4 - 1) * 5 + (5 - 1)]) * (b[(2 - 1) * 5 + (3 - 1)] + b[(5 - 1) * 5 + (1 - 1)]);
    h[7] = (-a[(1 - 1) * 5 + (1 - 1)] + a[(4 - 1) * 5 + (1 - 1)] - a[(4 - 1) * 5 + (2 - 1)]) * (b[(1 - 1) * 5 + (1 - 1)] + b[(2 - 1) * 5 + (4 - 1)]);
    h[8] = (a[(3 - 1) * 5 + (2 - 1)] - a[(3 - 1) * 5 + (3 - 1)] - a[(4 - 1) * 5 + (3 - 1)]) * (-b[(2 - 1) * 5 + (3 - 1)] + b[(3 - 1) * 5 + (1 - 1)]);
    h[9] = (a[(1 - 1) * 5 + (2 - 1)] - a[(1 - 1) * 5 + (4 - 1)] + a[(4 - 1) * 5 + (4 - 1)]) * (b[(2 - 1) * 5 + (3 - 1)] + b[(4 - 1) * 5 + (1 - 1)]);
    h[10] = (a[(2 - 1) * 5 + (2 - 1)] + a[(2 - 1) * 5 + (5 - 1)]) * b[(5 - 1) * 5 + (1 - 1)];
    h[11] = (-a[(2 - 1) * 5 + (1 - 1)] - a[(4 - 1) * 5 + (1 - 1)] + a[(4 - 1) * 5 + (2 - 1)]) * (-b[(1 - 1) * 5 + (1 - 1)] + b[(2 - 1) * 5 + (2 - 1)]);
    h[12] = (a[(4 - 1) * 5 + (1 - 1)] - a[(4 - 1) * 5 + (2 - 1)]) * -b[(1 - 1) * 5 + (1 - 1)];
    h[13] = (a[(1 - 1) * 5 + (2 - 1)] + a[(1 - 1) * 5 + (4 - 1)] + a[(2 - 1) * 5 + (4 - 1)]) * (b[(2 - 1) * 5 + (2 - 1)] + b[(4 - 1) * 5 + (1 - 1)]);
    h[14] = (a[(1 - 1) * 5 + (3 - 1)] - a[(3 - 1) * 5 + (2 - 1)] + a[(3 - 1) * 5 + (3 - 1)]) * (b[(2 - 1) * 5 + (4 - 1)] + b[(3 - 1) * 5 + (1 - 1)]);
    h[15] = (-a[(1 - 1) * 5 + (2 - 1)] - a[(1 - 1) * 5 + (4 - 1)]) * b[(4 - 1) * 5 + (1 - 1)];
    h[16] = (-a[(3 - 1) * 5 + (2 - 1)] + a[(3 - 1) * 5 + (3 - 1)]) * b[(3 - 1) * 5 + (1 - 1)];
    h[17] = (a[(1 - 1) * 5 + (2 - 1)] + a[(1 - 1) * 5 + (4 - 1)] - a[(2 - 1) * 5 + (1 - 1)] + a[(2 - 1) * 5 + (2 - 1)] - a[(2 - 1) * 5 + (3 - 1)] + a[(2 - 1) * 5 + (4 + 1)] - a[(3 - 1) * 5 + (2 + 1)] + a[(3 - 1) * 5 + (3 + 1)] - a[(4 - 1) * 5 + (1 + 1)] + a[(4 - 1) * 5 + (2 + 1)]) * b[(2 - 1) * 5 + (2 + 1)];
    h[18] = a[(2 - 1) * 5 + (1 - 1)] * (b[(1 - 1) * 5 + (1 - 1)] + b[(1 - 1) * 5 + (2 - 1)] + b[(5 - 1) + (2 - 1)]);
    h[19] = -a[(2 - 1) * 5 + (3 - 1)] * (b[(3 - 1) * 5 + (1 - 1)] + b[(3 - 1) * 5 + (2 - 1)] + b[(5 - 1) + (2 - 1)]);
    h[20] = (-a[(1 - 1) * 5 + (5 - 1)] + a[(2 - 1) * 5 + (1 - 1)] + a[(2 - 1) * 5 + (3 - 1)] - a[(2 - 1) + (5 - 1)]) * (-b[(1 - 1) * 5 + (1 - 1)] - b[(1 - 1) * 5 + (2 - 1)] + b[(1 - 1) * 5 + (4 - 1)] - b[(5 - 1) * 5 + (2 - 1)]);
    h[21] = (a[(2 - 1) * 5 + (1 - 1)] + a[(2 - 1) * 5 + (3 - 1)] - a[(2 - 1) * 5 + (5 - 1)]) * b[(5 - 1) + (2 - 1)];
    h[22] = (a[(1 - 1) * 5 + (3 - 1)] - a[(1 - 1) * 5 + (4 - 1)] - a[(2 - 1) * 5 + (4 - 1)]) * (b[(1 - 1) + (1 - 1)] + b[(1 - 1) * 5 + (2 - 1)] - b[(1 - 1) * 5 + (4 - 1)] - b[(3 - 1) * 5 + (1 - 1)] - b[(3 - 1) * 5 + (2 - 1)] + b[(3 - 1) * 5 + (4 - 1)] + b[(4 - 1) * 5 + (4 - 1)]);
    h[23] = a[(1 - 1) * 5 + (3 - 1)] * (-b[(3 - 1) * 5 + (1 - 1)] + b[(3 - 1) * 5 + (4 - 1)] + b[(4 - 1) + (4 - 1)]);
    h[24] = a[(1 - 1) * 5 + (5 - 1)] * (-b[(4 - 1) * 5 + (4 - 1)] - b[(5 - 1) * 5 + (1 - 1)] + b[(5 - 1) + (4 - 1)]);
    h[25] = -a[(1 - 1) * 5 + (1 - 1)] * (b[(1 - 1) * 5 + (1 - 1)] - b[(1 - 1) * 5 + (4 - 1)]);
    h[26] = (a[(1 - 1) * 5 + (3 - 1)] + a[(1 - 1) * 5 + (4 - 1)] + a[(1 - 1) * 5 + (5 - 1)]) * b[(4 - 1) * 5 + (4 - 1)];
    h[27] = (a[(1 - 1) * 5 + (3 - 1)] - a[(3 - 1) * 5 + (1 - 1)] + a[(3 - 1) * 5 + (3 - 1)]) * (b[(1 - 1) + (1 - 1)] - b[(1 - 1) * 5 + (4 - 1)] + b[(1 - 1) * 5 + (5 - 1)] + b[(3 - 1) * 5 + (5 - 1)]);
    h[28] = -a[(3 - 1) * 5 + (4 - 1)] * (-b[(3 - 1) * 5 + (5 - 1)] - b[(4 - 1) * 5 + (1 - 1)] - b[(4 - 1) + (5 - 1)]);
    h[29] = a[(3 - 1) * 5 + (1 - 1)] * (b[(1 - 1) * 5 + (1 - 1)] + b[(1 - 1) * 5 + (5 - 1)] + b[(3 - 1) + (5 - 1)]);
    h[30] = (a[(3 - 1) * 5 + (1 - 1)] - a[(3 - 1) * 5 + (3 - 1)] + a[(3 - 1) * 5 + (4 - 1)]) * b[(3 - 1) + (5 - 1)];
    h[31] = (-a[(1 - 1) * 5 + (4 - 1)] - a[(1 - 1) * 5 + (5 - 1)] - a[(3 - 1) * 5 + (4 - 1)]) * (-b[(4 - 1) + (4 - 1)] - b[(5 - 1) * 5 + (1 - 1)] + b[(5 - 1) * 5 + (4 - 1)] - b[(5 - 1) * 5 + (5 - 1)]);
    h[32] = (a[(2 - 1) * 5 + (1 - 1)] + a[(4 - 1) * 5 + (1 - 1)] + a[(4 - 1) * 5 + (4 - 1)]) * (b[(1 - 1) + (3 - 1)] - b[(4 - 1) * 5 + (1 - 1)] - b[(4 - 1) * 5 + (2 - 1)] - b[(4 - 1) * 5 + (3 - 1)]);
    h[33] = a[(4 - 1) * 5 + (3 - 1)] * (-b[(3 - 1) * 5 + (1 - 1)] - b[(3 - 1) * 5 + (3 - 1)]);
    h[34] = a[(4 - 1) * 5 + (4 - 1)] * (-b[(1 - 1) * 5 + (3 - 1)] + b[(4 - 1) * 5 + (1 - 1)] + b[(4 - 1) * 5 + (3 - 1)]);
    h[35] = -a[(4 - 1) * 5 + (5 - 1)] * (b[(1 - 1) * 5 + (3 - 1)] + b[(5 - 1) * 5 + (1 - 1)] + b[(5 - 1) * 5 + (3 - 1)]);
    h[36] = (a[(2 - 1) * 5 + (3 - 1)] - a[(2 - 1) * 5 + (5 - 1)] - a[(4 - 1) * 5 + (5 - 1)]) * (b[(3 - 1) * 5 + (1 - 1)] + b[(3 - 1) * 5 + (2 - 1)] + b[(3 - 1) * 5 + (3 - 1)] + b[(5 - 1) * 5 + (2 - 1)]);
    h[37] = (-a[(4 - 1) * 5 + (1 - 1)] - a[(4 - 1) * 5 + (4 - 1)] + a[(4 - 1) * 5 + (5 - 1)]) * b[(1 - 1) * 5 + (3 - 1)];
    h[38] = (-a[(2 - 1) * 5 + (3 - 1)] - a[(3 - 1) * 5 + (1 - 1)] + a[(3 - 1) * 5 + (3 - 1)] - a[(3 - 1) * 5 + (4 - 1)]) * (b[(3 - 1) * 5 + (5 - 1)] + b[(4 - 1) * 5 + (1 - 1)] + b[(4 - 1) * 5 + (2 - 1)] + b[(4 - 1) * 5 + (5 - 1)]);
    h[39] = (-a[(3 - 1) * 5 + (1 - 1)] - a[(4 - 1) * 5 + (1 - 1)] - a[(4 - 1) * 5 + (4 - 1)] + a[(4 - 1) * 5 + (5 - 1)]) * (b[(1 - 1) * 5 + (3 - 1)] + b[(5 - 1) * 5 + (1 - 1)] + b[(5 - 1) * 5 + (3 - 1)] + b[(5 - 1) * 5 + (5 - 1)]);
    h[40] = (-a[(1 - 1) * 5 + (3 - 1)] + a[(1 - 1) * 5 + (4 - 1)] + a[(1 - 1) * 5 + (5 - 1)] - a[(4 - 1) * 5 + (4 - 1)]) * (-b[(3 - 1) * 5 + (1 - 1)] - b[(3 - 1) * 5 + (3 - 1)] + b[(3 - 1) * 5 + (4 - 1)] + b[(4 - 1) * 5 + (4 - 1)]);
    h[41] = (-a[(1 - 1) * 5 + (1 - 1)] + a[(4 - 1) * 5 + (1 - 1)] - a[(4 - 1) * 5 + (5 - 1)]) * (b[(1 - 1) * 5 + (3 - 1)] + b[(3 - 1) * 5 + (1 - 1)] + b[(3 - 1) * 5 + (3 - 1)] - b[(3 - 1) * 5 + (4 - 1)] + b[(5 - 1) * 5 + (1 - 1)] + b[(5 - 1) * 5 + (3 - 1)] - b[(5 - 1) * 5 + (4 - 1)]);
    h[42] = (-a[(2 - 1) * 5 + (1 - 1)] + a[(2 - 1) * 5 + (5 - 1)] - a[(3 - 1) * 5 + (5 - 1)]) * (-b[(1 - 1) * 5 + (1 - 1)] - b[(1 - 1) * 5 + (2 - 1)] - b[(1 - 1) * 5 + (5 - 1)] + b[(4 - 1) * 5 + (1 - 1)] + b[(4 - 1) * 5 + (2 - 1)] + b[(4 - 1) * 5 + (5 - 1)] - b[(5 - 1) * 5 + (2 - 1)]);
    h[43] = a[(2 - 1) * 5 + (4 - 1)] * (b[(4 - 1) * 5 + (1 - 1)] + b[(4 - 1) * 5 + (2 - 1)]);
    h[44] = (a[(2 - 1) * 5 + (3 - 1)] + a[(3 - 1) * 5 + (2 - 1)] - a[(3 - 1) * 5 + (3 - 1)]) * (b[(2 - 1) * 5 + (2 - 1)] - b[(3 - 1) * 5 + (1 - 1)]);
    h[45] = (-a[(3 - 1) * 5 + (3 - 1)] + a[(3 - 1) * 5 + (4 - 1)] - a[(4 - 1) * 5 + (3 - 1)]) * (b[(3 - 1) * 5 + (5 - 1)] + b[(4 - 1) * 5 + (1 - 1)] + b[(4 - 1) * 5 + (3 - 1)] + b[(4 - 1) * 5 + (5 - 1)] + b[(5 - 1) * 5 + (1 - 1)] + b[(5 - 1) * 5 + (3 - 1)] + b[(5 - 1) * 5 + (5 - 1)]);
    h[46] = -a[(3 - 1) * 5 + (5 - 1)] * (-b[(5 - 1) * 5 + (1 - 1)] - b[(5 - 1) * 5 + (5 - 1)]);
    h[47] = (a[(2 - 1) * 5 + (1 - 1)] - a[(2 - 1) * 5 + (5 - 1)] - a[(3 - 1) * 5 + (1 - 1)] + a[(3 - 1) * 5 + (5 - 1)]) * (b[(1 - 1) * 5 + (1 - 1)] + b[(1 - 1) * 5 + (2 - 1)] + b[(1 - 1) * 5 + (5 - 1)] - b[(4 - 1) * 5 + (1 - 1)] - b[(4 - 1) * 5 + (2 - 1)] - b[(4 - 1) * 5 + (5 - 1)]);
    h[48] = (-a[(2 - 1) * 5 + (3 - 1)] + a[(3 - 1) * 5 + (3 - 1)]) * (b[(2 - 1) * 5 + (2 - 1)] + b[(3 - 1) * 5 + (2 - 1)] + b[(3 - 1) * 5 + (5 - 1)] + b[(4 - 1) * 5 + (1 - 1)] + b[(4 - 1) * 5 + (2 - 1)] + b[(4 - 1) * 5 + (5 - 1)]);
    h[49] = (-a[(1 - 1) * 5 + (1 - 1)] - a[(1 - 1) * 5 + (3 - 1)] + a[(1 - 1) * 5 + (4 - 1)] + a[(1 - 1) * 5 + (5 - 1)] - a[(2 - 1) * 5 + (1 - 1)] - a[(2 - 1) * 5 + (3 - 1)] + a[(2 - 1) * 5 + (4 - 1)] + a[(2 - 1) * 5 + (5 - 1)]) * (-b[(1 - 1) * 5 + (1 - 1)] - b[(1 - 1) * 5 + (2 - 1)] + b[(1 - 1) * 5 + (4 - 1)]);
    h[50] = (-a[(1 - 1) * 5 + (4 - 1)] - a[(2 - 1) * 5 + (4 - 1)]) * (b[(2 - 1) * 5 + (2 - 1)] - b[(3 - 1) * 5 + (1 - 1)] - b[(3 - 1) * 5 + (2 - 1)] + b[(3 - 1) * 5 + (4 - 1)] - b[(4 - 1) * 5 + (2 - 1)] + b[(4 - 1) * 5 + (4 - 1)]);
    h[51] = a[(2 - 1) * 5 + (2 - 1)] * (b[(2 - 1) * 5 + (1 - 1)] + b[(2 - 1) * 5 + (2 - 1)] - b[(5 - 1) * 5 + (1 - 1)]);
    h[52] = a[(4 - 1) * 5 + (2 - 1)] * (b[(1 - 1) * 5 + (1 - 1)] + b[(2 - 1) * 5 + (1 - 1)] + b[(2 - 1) * 5 + (3 - 1)]);
    h[53] = -a[(1 - 1) * 5 + (2 - 1)] * (-b[(2 - 1) * 5 + (1 - 1)] + b[(2 - 1) * 5 + (4 - 1)] + b[(4 - 1) * 5 + (1 - 1)]);
    h[54] = (a[(1 - 1) * 5 + (2 - 1)] + a[(1 - 1) * 5 + (4 - 1)] - a[(2 - 1) * 5 + (2 - 1)] - a[(2 - 1) * 5 + (5 - 1)] - a[(3 - 1) * 5 + (2 - 1)] + a[(3 - 1) * 5 + (3 - 1)] - a[(4 - 1) * 5 + (2 - 1)] + a[(4 - 1) * 5 + (3 - 1)] - a[(4 - 1) * 5 + (4 - 1)] - a[(4 - 1) * 5 + (5 - 1)]) * b[(2 - 1) * 5 + (3 - 1)];
    h[55] = (a[(1 - 1) * 5 + (4 - 1)] - a[(4 - 1) * 5 + (4 - 1)]) * (-b[(2 - 1) * 5 + (3 - 1)] + b[(3 - 1) * 5 + (1 - 1)] + b[(3 - 1) * 5 + (3 - 1)] - b[(3 - 1) * 5 + (4 - 1)] + b[(4 - 1) * 5 + (3 - 1)] - b[(4 - 1) * 5 + (4 - 1)]);
    h[56] = (a[(1 - 1) * 5 + (1 - 1)] - a[(1 - 1) * 5 + (5 - 1)] - a[(4 - 1) * 5 + (1 - 1)] + a[(4 - 1) * 5 + (5 - 1)]) * (b[(3 - 1) * 5 + (1 - 1)] + b[(3 - 1) * 5 + (3 - 1)] - b[(3 - 1) * 5 + (4 - 1)] + b[(5 - 1) * 5 + (1 - 1)] + b[(5 - 1) * 5 + (3 - 1)] - b[(5 - 1) * 5 + (4 - 1)]);
    h[57] = (-a[(3 - 1) * 5 + (1 - 1)] - a[(4 - 1) * 5 + (1 - 1)]) * (-b[(1 - 1) * 5 + (3 - 1)] - b[(1 - 1) * 5 + (5 - 1)] - b[(2 - 1) * 5 + (5 - 1)] - b[(5 - 1) * 5 + (1 - 1)] - b[(5 - 1) * 5 + (3 - 1)] - b[(5 - 1) * 5 + (5 - 1)]);
    h[58] = (a[(1 - 1) * 5 + (4 - 1)] - a[(1 - 1) * 5 + (5 - 1)] - a[(3 - 1) * 5 + (4 - 1)] - a[(3 - 1) * 5 + (5 - 1)]) * (-b[(5 - 1) * 5 + (1 - 1)] + b[(5 - 1) * 5 + (4 - 1)] - b[(5 - 1) * 5 + (5 - 1)]);
    h[59] = (-a[(3 - 1) * 5 + (3 - 1)] + a[(3 - 1) * 5 + (4 - 1)] - a[(4 - 1) * 5 + (3 - 1)] + a[(4 - 1) * 5 + (4 - 1)]) * (b[(4 - 1) * 5 + (1 - 1)] + b[(4 - 1) * 5 + (3 - 1)] + b[(4 - 1) * 5 + (5 - 1)] + b[(5 - 1) * 5 + (1 - 1)] + b[(5 - 1) * 5 + (3 - 1)] + b[(5 - 1) * 5 + (5 - 1)]);
    h[60] = (a[(2 - 1) * 5 + (5 - 1)] + a[(4 - 1) * 5 + (5 - 1)]) * (b[(2 - 1) * 5 + (3 - 1)] - b[(3 - 1) * 5 + (1 - 1)] - b[(3 - 1) * 5 + (2 - 1)] - b[(3 - 1) * 5 + (3 - 1)] - b[(5 - 1) * 5 + (2 - 1)] - b[(5 - 1) * 5 + (3 - 1)]);
    h[61] = (a[(1 - 1) * 5 + (4 - 1)] + a[(3 - 1) * 5 + (4 - 1)]) * (b[(1 - 1) * 5 + (1 - 1)] - b[(1 - 1) * 5 + (4 - 1)] + b[(1 - 1) * 5 + (5 - 1)] - b[(2 - 1) * 5 + (5 - 1)] - b[(4 - 1) * 5 + (4 - 1)] + b[(4 - 1) * 5 + (5 - 1)] - b[(5 - 1) * 5 + (1 - 1)] + b[(5 - 1) * 5 + (4 - 1)] - b[(5 - 1) * 5 + (5 - 1)]);
    h[62] = (a[(2 - 1) * 5 + (1 - 1)] + a[(4 - 1) * 5 + (1 - 1)]) * (b[(1 - 1) * 5 + (2 - 1)] + b[(1 - 1) * 5 + (3 - 1)] + b[(2 - 1) * 5 + (2 - 1)] - b[(4 - 1) * 5 + (1 - 1)] - b[(4 - 1) * 5 + (2 - 1)] - b[(4 - 1) * 5 + (3 - 1)]);
    h[63] = (-a[(3 - 1) * 5 + (3 - 1)] + a[(4 - 1) * 5 + (3 - 1)]) * (-b[(2 - 1) * 5 + (3 - 1)] - b[(3 - 1) * 5 + (3 - 1)] - b[(3 - 1) * 5 + (5 - 1)] - b[(4 - 1) * 5 + (1 - 1)] - b[(4 - 1) * 5 + (3 - 1)] - b[(4 - 1) * 5 + (5 - 1)]);
    h[64] = (a[(1 - 1) * 5 + (1 - 1)] - a[(1 - 1) * 5 + (3 - 1)] - a[(1 - 1) * 5 + (4 - 1)] + a[(3 - 1) * 5 + (1 - 1)] - a[(3 - 1) * 5 + (3 - 1)] - a[(3 - 1) * 5 + (4 - 1)]) * (b[(1 - 1) * 5 + (1 - 1)] - b[(1 - 1) * 5 + (4 - 1)] + b[(1 - 1) * 5 + (5 - 1)]);
    h[65] = (-a[(1 - 1) * 5 + (1 - 1)] + a[(4 - 1) * 5 + (1 - 1)]) * (-b[(1 - 1) * 5 + (3 - 1)] + b[(1 - 1) * 5 + (4 - 1)] + b[(2 - 1) * 5 + (4 - 1)] - b[(5 - 1) * 5 + (1 - 1)] - b[(5 - 1) * 5 + (3 - 1)] + b[(5 - 1) * 5 + (4 - 1)]);
    h[66] = (a[(1 - 1) * 5 + (1 - 1)] - a[(1 - 1) * 5 + (2 - 1)] + a[(1 - 1) * 5 + (3 - 1)] - a[(1 - 1) * 5 + (5 - 1)] - a[(2 - 1) * 5 + (2 - 1)] - a[(2 - 1) * 5 + (5 - 1)] - a[(3 - 1) * 5 + (2 - 1)] + a[(3 - 1) * 5 + (3 - 1)] - a[(4 - 1) * 5 + (1 - 1)] + a[(4 - 1) * 5 + (2 - 1)]) * b[(2 - 1) * 5 + (4 - 1)];
    h[67] = (a[(2 - 1) * 5 + (5 - 1)] - a[(3 - 1) * 5 + (5 - 1)]) * (b[(1 - 1) * 5 + (1 - 1)] + b[(1 - 1) * 5 + (2 - 1)] + b[(1 - 1) * 5 + (5 - 1)] - b[(2 - 1) * 5 + (5 - 1)] - b[(4 - 1) * 5 + (1 - 1)] - b[(4 - 1) * 5 + (2 - 1)] - b[(4 - 1) * 5 + (5 - 1)] + b[(5 - 1) * 5 + (2 - 1)] + b[(5 - 1) * 5 + (5 - 1)]);
    h[68] = (a[(1 - 1) * 5 + (1 - 1)] + a[(1 - 1) * 5 + (3 - 1)] - a[(1 - 1) * 5 + (4 - 1)] - a[(1 - 1) * 5 + (5 - 1)] - a[(4 - 1) * 5 + (1 - 1)] - a[(4 - 1) * 5 + (3 - 1)] + a[(4 - 1) * 5 + (4 - 1)] + a[(4 - 1) * 5 + (5 - 1)]) * (-b[(3 - 1) * 5 + (1 - 1)] - b[(3 - 1) * 5 + (3 - 1)] + b[(3 - 1) * 5 + (4 - 1)]);
    h[69] = (-a[(1 - 1) * 5 + (3 - 1)] + a[(1 - 1) * 5 + (4 - 1)] - a[(2 - 1) * 5 + (3 - 1)] + a[(2 - 1) * 5 + (4 - 1)]) * (-b[(2 - 1) * 5 + (4 - 1)] - b[(3 - 1) * 5 + (1 - 1)] - b[(3 - 1) * 5 + (2 - 1)] + b[(3 - 1) * 5 + (4 - 1)] - b[(5 - 1) * 5 + (2 - 1)] + b[(5 - 1) * 5 + (4 - 1)]);
    h[70] = (a[(2 - 1) * 5 + (3 - 1)] + a[(2 - 1) * 5 + (5 - 1)] + a[(4 - 1) * 5 + (3 - 1)] - a[(4 - 1) * 5 + (5 - 1)]) * (-b[(3 - 1) * 5 + (1 - 1)] - b[(3 - 1) * 5 + (2 - 1)] - b[(3 - 1) * 5 + (3 - 1)]);
    h[71] = (-a[(3 - 1) * 5 + (1 - 1)] + a[(3 - 1) * 5 + (3 - 1)] - a[(3 - 1) * 5 + (4 - 1)] + a[(3 - 1) * 5 + (5 - 1)] - a[(4 - 1) * 5 + (1 - 1)] + a[(4 - 1) * 5 + (3 - 1)] - a[(4 - 1) * 5 + (4 - 1)] + a[(4 - 1) * 5 + (5 - 1)]) * (-b[(5 - 1) * 5 + (1 - 1)] - b[(5 - 1) * 5 + (3 - 1)] - b[(5 - 1) * 5 + (5 - 1)]);
    h[72] = (-a[(2 - 1) * 5 + (1 - 1)] - a[(2 - 1) * 5 + (4 - 1)] - a[(4 - 1) * 5 + (1 - 1)] - a[(4 - 1) * 5 + (4 - 1)]) * (b[(4 - 1) * 5 + (1 - 1)] + b[(4 - 1) * 5 + (2 - 1)] + b[(4 - 1) * 5 + (3 - 1)]);
    h[73] = (a[(1 - 1) * 5 + (3 - 1)] - a[(1 - 1) * 5 + (4 - 1)] - a[(1 - 1) * 5 + (5 - 1)] + a[(2 - 1) * 5 + (3 - 1)] - a[(2 - 1) * 5 + (4 - 1)] - a[(2 - 1) * 5 + (5 - 1)]) * (b[(1 - 1) * 5 + (1 - 1)] + b[(1 - 1) * 5 + (2 - 1)] - b[(1 - 1) * 5 + (4 - 1)] + b[(2 - 1) * 5 + (4 - 1)] + b[(5 - 1) * 5 + (2 - 1)] - b[(5 - 1) * 5 + (4 - 1)]);
    h[74] = (a[(2 - 1) * 5 + (1 - 1)] - a[(2 - 1) * 5 + (3 - 1)] + a[(2 - 1) * 5 + (4 - 1)] - a[(3 - 1) * 5 + (1 - 1)] + a[(3 - 1) * 5 + (3 - 1)] - a[(3 - 1) * 5 + (4 - 1)]) * (b[(4 - 1) * 5 + (1 - 1)] + b[(4 - 1) * 5 + (2 - 1)] + b[(4 - 1) * 5 + (5 - 1)]);
    h[75] = (a[(1 - 1) * 5 + (2 - 1)] + a[(1 - 1) * 5 + (4 - 1)] - a[(2 - 1) * 5 + (2 - 1)] - a[(2 - 1) * 5 + (5 - 1)] - a[(3 - 1) * 5 + (1 - 1)] + a[(3 - 1) * 5 + (2 - 1)] + a[(3 - 1) * 5 + (4 - 1)] + a[(3 - 1) * 5 + (5 - 1)] - a[(4 - 1) * 5 + (1 - 1)] + a[(4 - 1) * 5 + (2 - 1)]) * b[(2 - 1) * 5 + (5 - 1)];
    h[76] = (a[(1 - 1) * 5 + (3 - 1)] + a[(3 - 1) * 5 + (3 - 1)]) * (-b[(1 - 1) * 5 + (1 - 1)] + b[(1 - 1) * 5 + (4 - 1)] - b[(1 - 1) * 5 + (5 - 1)] + b[(2 - 1) * 5 + (4 - 1)] + b[(3 - 1) * 5 + (4 - 1)] - b[(3 - 1) * 5 + (5 - 1)]);

    c[(1 - 1) * 5 + (1 - 1)] = -h[10] + h[12] + h[14] - h[15] - h[16] + h[53] + h[5] - h[66] - h[7];
    c[(2 - 1) * 5 + (1 - 1)] = h[10] + h[11] - h[12] + h[13] + h[15] + h[16] - h[17] - h[44] + h[51];
    c[(3 - 1) * 5 + (1 - 1)] = h[10] - h[12] + h[15] + h[16] - h[1] + h[2] + h[3] - h[4] + h[75];
    c[(4 - 1) * 5 + (1 - 1)] = -h[10] + h[12] - h[15] - h[16] + h[52] + h[54] - h[6] - h[8] + h[9];
    c[(1 - 1) * 5 + (2 - 1)] = h[13] + h[15] + h[20] + h[21] - h[22] + h[23] + h[25] - h[43] + h[49] + h[50];
    c[(2 - 1) * 5 + (2 - 1)] = -h[11] + h[12] - h[13] - h[15] - h[16] + h[17] + h[18] - h[19] - h[21] + h[43] + h[44];
    c[(3 - 1) * 5 + (2 - 1)] = -h[16] - h[19] - h[21] - h[28] - h[29] - h[38] + h[42] + h[44] - h[47] + h[48];
    c[(4 - 1) * 5 + (2 - 1)] = h[11] - h[12] - h[18] + h[21] - h[32] + h[33] - h[34] - h[36] + h[62] - h[70];
    c[(1 - 1) * 5 + (3 - 1)] = h[15] + h[23] + h[24] + h[34] - h[37] + h[40] - h[41] + h[55] - h[56] - h[9];
    c[(2 - 1) * 5 + (3 - 1)] = -h[10] + h[19] + h[32] + h[35] + h[36] + h[37] - h[43] - h[60] - h[6] - h[72];
    c[(3 - 1) * 5 + (3 - 1)] = -h[16] - h[28] + h[33] + h[37] - h[39] + h[45] - h[46] + h[63] - h[71] - h[8];
    c[(4 - 1) * 5 + (3 - 1)] = h[10] + h[15] + h[16] - h[33] + h[34] - h[35] - h[37] - h[54] + h[6] + h[8] - h[9];
    c[(1 - 1) * 5 + (4 - 1)] = -h[10] + h[12] + h[14] - h[16] + h[23] + h[24] + h[25] + h[26] + h[5] - h[66] - h[7];
    c[(2 - 1) * 5 + (4 - 1)] = h[10] + h[18] - h[19] + h[20] - h[22] - h[24] - h[26] - h[5] - h[69] + h[73];
    c[(3 - 1) * 5 + (4 - 1)] = -h[14] + h[16] - h[23] - h[26] + h[27] + h[29] + h[31] + h[46] - h[58] + h[76];
    c[(4 - 1) * 5 + (4 - 1)] = h[12] + h[25] + h[26] - h[33] - h[35] - h[40] + h[41] + h[65] - h[68] - h[7];
    c[(1 - 1) * 5 + (5 - 1)] = h[15] + h[24] + h[25] + h[27] - h[28] + h[30] + h[31] - h[4] + h[61] + h[64];
    c[(2 - 1) * 5 + (5 - 1)] = -h[10] - h[18] - h[2] - h[30] - h[38] + h[42] - h[43] + h[46] + h[67] + h[74];
    c[(3 - 1) * 5 + (5 - 1)] = -h[10] + h[12] - h[15] + h[28] + h[29] - h[2] - h[30] - h[3] + h[46] + h[4] - h[75];
    c[(4 - 1) * 5 + (5 - 1)] = -h[12] - h[29] + h[30] - h[34] + h[35] + h[39] + h[3] - h[45] + h[57] + h[59];
}
