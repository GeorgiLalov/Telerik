function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var h = +args[2];

    var answer = h * ( (a + b) / 2 );

    console.log(answer.toFixed(7));
}
