const { expect } = require('chai')
const { solution, rowToString } = require('./1.1.11')

describe('rowToString', () => {
  it('throws an error if argument is null', () => {
    expect(() => rowToString(null)).to.throw('Array is required.')
  })

  it('returns correct string for [false, false, false]', () => {
    expect(rowToString([false, false, false])).to.equal('     ')
  })

  it('returns correct string for [true, true, true]', () => {
    expect(rowToString([true, true, true])).to.equal('* * *')
  })

  it('returns correct string for [true, false, true]', () => {
    expect(rowToString([true, false, true])).to.equal('*   *')
  })
})

describe('solution', () => {
  it('throws an error if argument is null', () => {
    expect(() => solution(null)).to.throw('Array is required.')
  })

  it('prints correct grid', () => {
    expect(
      solution([
        [true, true, true],
        [false, false, false],
        [true, false, true],
      ])
    ).to.equal('  1 2 3\n1 * * *\n2      \n3 *   *')
  })

  it.skip('prints correct spacing with 11+ columns', () => {
    // TODO, current solution doesn't account for greater width of multi-digit column headers.
  })

  it.skip('prints correct spacing with 11+ rows', () => {
    // TODO, current solution doesn't account for greater width of multi-digit row headers.
  })
})
