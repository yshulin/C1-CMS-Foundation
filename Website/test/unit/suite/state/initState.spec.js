import expect from 'unittest/helpers/expect.js';
import sinon from 'sinon';
import Immutable from 'immutable';
import initState from 'console/state/initState.js';

describe('initState', () => {
	let store;
	beforeEach(() => {
		store = {
			dispatch: sinon.spy().named('dispatch'),
			getState: () => Immutable.fromJS({
				perspectiveDefs: {
					test: {
						rootPage: 'testpage'
					}
				},
				layout: {
					currentPerspective: 'test'
				}
			})
		};
	});

	it('loads definitions, sets page list, the shown page', () =>
		expect(initState, 'when called with', [store], 'to be undefined')
		.then(() =>
			expect(store.dispatch, 'to have calls satisfying', [
				{ spy: store.dispatch, args: [expect.it('to be a function')]}
			])
		)
	);
});
