import readline from 'readline'

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
})

function log(...args) {
  console.log(...args)
}

function prompt(message, callback) {
  rl.question(message, callback)
}

function promptClose() {
  rl.close()
}

export { log, prompt, promptClose }
