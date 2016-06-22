function solve(args) {
    var number = +args[0];

    if ((Math.abs(number) % 2) === 0) {
      var answer = 'even ' + number;
    }
    else {
      answer = 'odd ' + number;
    }

    console.log(answer);
}
