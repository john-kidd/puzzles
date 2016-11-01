function print(x) {
    console.log(x);
    document.getElementById('result').innerText = x;
}

function main() {
    var n = 2;
    var array = [1,2,3,4,5];
    var result = rotateLeft(array, n);
    print(result);
}