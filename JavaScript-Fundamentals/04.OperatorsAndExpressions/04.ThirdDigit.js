function solve(args) {
    var strNumber = args[0];
    var nthNumber = strNumber.charAt(strNumber.length - 3);

    if (strNumber.length < 3) {
      var answer = 'false ' + 0;
    }
    else {
      if (nthNumber === '7') {
        answer = 'true';
      }
      else {
        answer = 'false ' + nthNumber;
      }
    }


    console.log(answer);
}
