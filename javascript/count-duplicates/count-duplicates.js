'use strict';

var countDuplicates = function(input) {    
    var output = [];
    input.forEach(function(element) {
        var chars = element.split('');
        var previous = null;
        output.push(chars.reduce(function(n, val) {
            var charsToDelete = n + (val === previous);
            previous = val;
            return charsToDelete;
        }, 0));
    });

    return output;
};

module.exports = countDuplicates;