const expect = require('chai').expect
const solution = require('./1.1.5.js')

describe('solution', () => {
  it('returns true for both in range', () => {
    expect(solution(0.1, 0.9)).to.be.true
  })

  it('returns false for 0', () => {
    expect(solution(0, 0.9)).to.be.false
  })

  it('returns false for 1', () => {
    expect(solution(0.1, 1)).to.be.false
  })

  it('returns false for less than 0', () => {
    expect(solution(-0.1, 0.9)).to.be.false
  })

  it('returns false for greater than 1', () => {
    expect(solution(0.1, 1.1)).to.be.false
  })

  it('returns false for both out of range', () => {
    expect(solution(-0.1, 1.1)).to.be.false
  })
})
