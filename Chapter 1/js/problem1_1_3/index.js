const { log, prompt } = require('./console.js')
const { solution } = require('./1.1.3.js')

async function run() {
  let loop = true

  while (loop) {
    // Prompt the user and log the result.
    log(await solution())

    // Ask the user if they have more inputs to check.
    const goAgain = await prompt('Would you like to check another set?: [y/n]')
    if (goAgain.toLowerCase() !== 'y') loop = false
  }

  process.exit()
}

run()
