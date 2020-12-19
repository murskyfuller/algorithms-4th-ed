const { expect } = require('chai')
const { solution, isDivisibleBy } = require('./1.1.9')

describe('isDivisibleBy', () => {
  it('returns true for 4 and 2', () => {
    expect(isDivisibleBy(4, 2)).to.be.true
  })

  it('returns true for 4 and 3', () => {
    expect(isDivisibleBy(4, 3)).to.be.false
  })

  it('returns true for 9 and 3', () => {
    expect(isDivisibleBy(9, 3)).to.be.true
  })

  it('returns true for 9 and 4', () => {
    expect(isDivisibleBy(9, 4)).to.be.false
  })
})

describe('solution', () => {
  it('returns a string', () => {
    expect(typeof solution(1)).to.equal('string')
  })

  it('returns correct value for 1', () => {
    expect(solution(1)).to.equal('1')
  })

  it('returns correct value for 2', () => {
    expect(solution(2)).to.equal('10')
  })

  it('returns correct value for 3', () => {
    expect(solution(3)).to.equal('11')
  })

  it('returns correct value for 7', () => {
    expect(solution(7)).to.equal('111')
  })

  it('returns correct value for 8', () => {
    expect(solution(8)).to.equal('1000')
  })

  it('returns correct value for 13', () => {
    expect(solution(13)).to.equal('1101')
  })

  it('returns correct value for 15', () => {
    expect(solution(15)).to.equal('1111')
  })

  it('returns correct value for 16', () => {
    expect(solution(16)).to.equal('10000')
  })

  it('returns correct value for 17', () => {
    expect(solution(17)).to.equal('10001')
  })

  it('returns correct value for 54673890', () => {
    expect(solution(54673890)).to.equal('11010000100100000111100010')
  })
})
