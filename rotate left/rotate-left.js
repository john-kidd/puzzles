var rotateLeft = function(array, n) {
    var result = array.slice();
    for(var i = 0; i < n; i++) {
        var temp = result.shift();
        result.splice(array.length, 0, temp);
    }
    return result;
}
