describe('multiply', function() {
    var multiply = require('../multiply/multiply');

    it('3*5=15', function(){
        // arrange
        var a = 3;
        var b = 5;
        var expected = 15;

        // act
        var actual = multiply(a, b);

        // assert
        expect(actual).toEqual(expected);
    });

    it('-5*-5=25', function(){
        // arrange
        var a = -5;
        var b = -5;
        var expected = 25;

        // act
        var actual = multiply(a, b);

        // assert
        expect(actual).toEqual(expected);
    });

    it('1000*10=10000', function(){
        // arrange
        var a = 1000;
        var b = 10;
        var expected = 10000;

        // act
        var actual = multiply(a, b);

        // assert
        expect(actual).toEqual(expected);
    });
});