function solve(args) {
    var number = +args[0];
    var answer = 'true';

    if (number <= 0) {
      answer = 'false';
    }
    else {
      for (var i = 2; i < (number); i += 1) {
        if ( (number % i) == 0 ) {
          answer = 'false';
          break;
        }
      }
    }

    console.log(answer);
}
