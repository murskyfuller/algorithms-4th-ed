const consoleFuncs = require('./console.js')
const solutionFuncs = require('./1.1.3.js')

jest.mock('./console.js')

describe('Exercise 1.1.3 allEqual.', function () {
  it('Returns true for equal numbers.', function () {
    expect(solutionFuncs.areEqual(1, 1, 1)).toBeTruthy()
  })

  it('Returns false for unequal numbers.', function () {
    expect(solutionFuncs.areEqual(1, 2, 1)).toBeFalsy()
  })

  it('Returns true for equal strings.', function () {
    expect(solutionFuncs.areEqual('abc', 'abc', 'abc')).toBeTruthy()
  })

  it('Returns false for unequal strings.', function () {
    expect(solutionFuncs.areEqual('abc', 'bac', 'abc')).toBeFalsy()
  })

  it('Returns true for equal booleans.', function () {
    expect(solutionFuncs.areEqual(true, true, true)).toBeTruthy()
  })

  it('Returns false for unequal booleans.', function () {
    expect(solutionFuncs.areEqual(true, true, false)).toBeFalsy()
  })

  it('Returns true for equal objects.', function () {
    const obj = {}
    expect(solutionFuncs.areEqual(obj, obj, obj)).toBeTruthy()
  })

  it('Returns false for unequal objects.', function () {
    const obj = {}
    expect(solutionFuncs.areEqual({}, obj, obj)).toBeFalsy()
  })
})

describe('Exercise 1.1.3 solution.', function () {
  afterEach(function () {
    consoleFuncs.prompt.mockReset()
  })

  it("Calls log with 'equal'.", async function (done) {
    consoleFuncs.prompt.mockResolvedValue('1,1,1')

    // Act
    const result = await solutionFuncs.solution()

    // Assert
    expect(consoleFuncs.prompt).toBeCalledTimes(1)
    expect(result).toEqual('equal')

    done()
  })

  it("Calls log with 'not equal'.", async function (done) {
    consoleFuncs.prompt.mockResolvedValue('1,2,2')

    // Act
    const result = await solutionFuncs.solution()

    // Assert
    expect(consoleFuncs.prompt).toBeCalledTimes(1)
    expect(result).toEqual('not equal')

    done()
  })
})
