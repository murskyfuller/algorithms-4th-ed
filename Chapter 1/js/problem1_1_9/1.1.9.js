/**
 * Determines whether the first argument is evenly divisible by the second.
 * @param {number} n The number to check.
 * @param {number} divisor The number to divide by.
 * @returns {bool} True if the first argument is evenly divisible by the second, otherwise false.
 */
function isDivisibleBy(n, divisor) {
  return n % divisor === 0
}

/**
 * Generates the binary representation of a number and returns it as a string.
 * @param {number} n The integer to convert to a binary string representation.
 * @returns {string} The binary string representation of the provided integer.
 */
function binaryString(n) {
  let result = ''

  // Build the string by check each binary position's even-odd property.
  for (let i = n; i > 0; i = Math.floor(i / 2))
    result = `${isDivisibleBy(i, 2) ? '0' : '1'}${result}`

  return result
}

module.exports = { solution: binaryString, isDivisibleBy }
