var test1 = function(){
    'use strict';
    
    var input = ['AAAA', 'BBBBB', 'ABABABAB', 'BABABA', 'AAABBB'];
    
    input.forEach(function(element) {
        var chars = element.split('');
        var previous = null;
        var count = chars.reduce(function(n, val) {
            var charsToDelete = n + (val === previous);
            previous = val;
            return charsToDelete;
        }, 0);
        console.info(count.toString());
    });
};