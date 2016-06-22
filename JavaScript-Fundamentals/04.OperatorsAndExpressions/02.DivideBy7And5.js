function solve(args) {
    var number = +args[0];

    if ( ((number % 7) == 0) && ((number % 5) == 0) ) {
      var answer = 'true ' + number;
    }
    else {
      answer = 'false ' + number;
    }

    console.log(answer);
}
