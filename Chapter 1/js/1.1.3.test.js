import chai from 'chai'
import sinon from 'sinon'
import { log, prompt } from './console.js'
import { solution, areEqual } from './1.1.3.js'

const { expect } = chai

describe('Exercise 1.1.3 allEqual.', function () {
  it('Returns true for equal numbers.', function () {
    expect(() => areEqual(1, 1, 1)).to.be.true
  })

  it('Returns false for unequal numbers.', function () {
    expect(() => areEqual(1, 2, 1)).to.be.false
  })

  it('Returns true for equal strings.', function () {
    expect(() => areEqual('abc', 'abc', 'abc')).to.be.true
  })

  it('Returns false for unequal strings.', function () {
    expect(() => areEqual('abc', 'bac', 'abc')).to.be.false
  })

  it('Returns true for equal booleans.', function () {
    expect(() => areEqual(true, true, true)).to.be.true
  })

  it('Returns false for unequal booleans.', function () {
    expect(() => areEqual(true, true, false)).to.be.false
  })

  it('Returns true for equal objects.', function () {
    const obj = {}
    expect(() => areEqual(obj, obj, obj)).to.be.true
  })

  it('Returns false for unequal objects.', function () {
    const obj = {}
    expect(() => areEqual({}, obj, obj)).to.be.false
  })
})

describe('Exercise 1.1.3 solution.', function () {
  const sandbox = sinon.createSandbox()

  beforeEach(function () {
    sandbox.spy(areEqual)
    sandbox.spy(log)
  })

  afterEach(function () {
    sandbox.restore()
  })

  it("Calls log with 'equal'.", function () {
    // Act
    solution()

    process.nextTick(function mockResponse() {
      stdin.send('1 1 1')
    })

    // Assert
    expect(prompt).to.have.been.calledOnce
    expect(areEqual).to.have.been.calledOnce
    expect(areEqual).to.have.been.calledWith(1, 1, 1)
    expect(log).to.have.been.calledOnce
    expect(log).to.have.been.calledWith('equal')
  })

  it("Calls log with 'not equal'.", function () {
    // Act
    solution()

    process.nextTick(function mockResponse() {
      stdin.send('1 2 2')
    })

    // Assert
    expect(prompt).to.have.been.calledOnce
    expect(areEqual).to.have.been.calledOnce
    expect(areEqual).to.have.been.calledWith(1, 2, 2)
    expect(log).to.have.been.calledOnce
    expect(log).to.have.been.calledWith('not equal')
  })
})
