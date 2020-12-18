const consoleFuncs = require('./console.js')
const { prompt } = consoleFuncs

/**
 * Shallow comparison of all arguments.
 * @param  {...any} args The values to check.
 * @returns True if all arguments are equal to each other, otherwise false.
 */
function areEqual(...args) {
  return new Set(args).size <= 1
}

async function solution() {
  // Request input from user.
  const input = await prompt(
    "Enter three integers to test separated by spaces (e.g. '1,2,3'):"
  )

  // Parse the input as integers.
  const splits = input ? input.split(',') : []
  const numbers = []

  for (let i = 0, n = splits.length; i < n; i++) {
    let s = splits[i]
    while (true) {
      try {
        const num = Number(s)
        if (isNaN(num)) throw new Error('Not a number')
        numbers.push(num)
        break
      } catch {
        // If any value is not a valid integer, request a replacement
        // from the user.
        s = await prompt(
          `${s} is an invalid integer. Please enter a replacement:`
        )
      }
    }
  }

  return areEqual(...numbers) ? 'equal' : 'not equal'
}

module.exports = { solution, areEqual }
