/**
 * Determines whether all provided double values are strictly between
 * 0 and 1.
 * @param  {...number} args The double values to check.
 * @returns {boolean} True if all provided values are strictly between 0 and 1, otherwise false.
 */
function solution(...args) {
  return args.every((v) => v > 0 && v < 1)
}

module.exports = solution
