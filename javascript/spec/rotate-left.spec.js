describe('rotate-left', function(){
    var rotateLeft = require('../rotate-left/rotate-left');

    it('2,[1,2,3,4,5]', function() {
        // arrange
        var n = 2;
        var input = [1,2,3,4,5];
        var expected = [3,4,5,1,2];

        // act
        var actual = rotateLeft(input, n);

        // assert
        expect(actual).toEqual(expected);
    });
});