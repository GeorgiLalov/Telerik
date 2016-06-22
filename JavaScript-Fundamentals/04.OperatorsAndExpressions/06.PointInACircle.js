function solve(args) {
    var x = Math.abs(+args[0]);
    var y = Math.abs(+args[1]);

    if (x !== 0 && y !== 0) {
        var radius = Math.sqrt( (x * x) + (y * y) );
    }
    else {
      radius = Math.max(x, y);
    }

    if (radius <= 2) {
      var answer = 'yes ' + radius.toFixed(2);
    }
    else {
      answer = 'no ' + radius.toFixed(2);
    }

    console.log(answer);
}
