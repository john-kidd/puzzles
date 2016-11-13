'use strict';

var rotateLeft = function(input, n) {
    var output = input.slice();
    for(var i = 0; i < n; i++) {
        var temp = output.shift();
        output.splice(input.length, 0, temp);
    }
    return output;
}

module.exports = rotateLeft;
