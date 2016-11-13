'use strict';

var multiply = function(a, b) {
    if (a < 0 && b < 0) 
        return multiply(-a, -b);
        
    var x = a > b ? b : a;
    var y = a > b ? a : b;
    var result = 0;


    for(var i = 0; i < y; i++) 
        result += x;

    return result;
}

module.exports = multiply;