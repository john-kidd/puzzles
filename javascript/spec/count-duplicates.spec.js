describe('count-duplciates', function(){

    var countDuplicates = require('../count-duplicates/count-duplicates');

    it('test 5 strings', function() {
        // arrange
        var n = 2;
        var input = ['AAAA', 'BBBBB', 'ABABABAB', 'BABABA', 'AAABBB'];
        var expected = [3,4,0,0,4];

        // act
        var actual = countDuplicates(input, n);

        // assert
        expect(actual).toEqual(expected);
    });
});