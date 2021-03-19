function changeSystem(num, systemNum) {
  let tempNum = num;
  let multiplier = 1;
  let outputNum = 0;
  while (tempNum >= systemNum) {
    outputNum = outputNum + tempNum % systemNum * multiplier;
    tempNum = Math.floor(tempNum/systemNum);
    multiplier = multiplier * 10;
  }
  outputNum = outputNum + tempNum % systemNum * multiplier;
  return outputNum;
}

function calcDifference(num) {
  let prevNum = num;
  let remains = Math.floor(prevNum/10);
  let sum = 0;
  let multiplies = 1;
  let digit = 0;
  while (remains !== 0) {
    digit = prevNum % 10;
    sum = sum + digit;
    multiplies = multiplies * digit;
    prevNum = remains;
    remains = Math.floor(remains/10);
  }
  digit = prevNum % 10;
  sum = sum + digit;
  multiplies = multiplies * digit;
  return multiplies - sum;
}

let n = parseInt(prompt('Введите число'));
let k = parseInt(prompt('Введите систему исчисления'));

let changedNum = changeSystem(n, k);

alert(calcDifference(changedNum));