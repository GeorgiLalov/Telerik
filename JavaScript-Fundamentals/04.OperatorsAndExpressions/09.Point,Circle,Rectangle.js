function solve(args) {
    var x = +args[0];
    var y = +args[1];

    if ( ( ( x >= -1 ) && ( x <= 5 ) ) && ( ( y >= -1 ) && ( y <= 1 ) ) ) {
        var recAnswer = 'inside rectangle';
    }
    else {
        recAnswer = 'outside rectangle';
    }

    x = x - 1;
    y = y - 1;
    x = Math.abs(x);
    y = Math.abs(y);

    if (x !== 0 && y !== 0) {
        var radius = Math.sqrt( (x * x) + (y * y) );
    }
    else {
      radius = Math.max(x, y);
    }

    if (radius <= 1.5) {
      var cirAnswer = 'inside circle';
    }
    else {
      cirAnswer = 'outside circle';
    }

    console.log(cirAnswer + ' ' + recAnswer);
}
