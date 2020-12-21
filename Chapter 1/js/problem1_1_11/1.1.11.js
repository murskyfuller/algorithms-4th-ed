/**
 * Converts the provided array to a string representation for printing to the console.
 * @param {boolean[]} arr The array to convert to a string.
 * @returns {string} A string representation of the row.
 */
function rowToString(arr) {
  if (!arr) throw new Error('Array is required.')

  return arr.map((v) => (v ? '*' : ' ')).join(' ')
}

/**
 * Prints the two-dimensional array line by line.
 * @param {boolean[][]} arr A 2D array containing boolean values.
 */
function solution(arr) {
  if (!arr) throw new Error('Array is required.')

  let result = ''
  if (arr.length > 0) {
    // Create column header.
    const rowHeaderPadding = '  ' // Define space for row headers to fall under.
    const columnHeader = `${rowHeaderPadding}${[
      ...new Array(arr[0].length).fill(null).map((_, ix) => ix + 1),
    ].join(' ')}`

    // Generate the grid's rows.
    result += `${columnHeader}\n${arr
      .map((row, ix) => `${ix + 1} ${rowToString(row)}`)
      .join('\n')}`
  }

  return result
}

module.exports = { solution, rowToString }
