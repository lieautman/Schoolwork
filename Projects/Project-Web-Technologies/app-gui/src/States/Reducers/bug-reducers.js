const INITIAL_STATE = {
  bugList: [],
  perosnalBugList: [],
  error: null,
  fetching: false,
  fetched: false,
};

export default function reducer(state = INITIAL_STATE, action) {
  switch (action.type) {
    case 'GET_BUGS_PENDING':
    case 'CREATE_BUG_PENDING':
    case 'DELETE_BUG_PENDING':
    case 'UPDATE_BUG_PENDING':
    case 'SOLVE_BUG_PENDING':
    case 'GET_PERSONAL_BUGS_PENDING':
      return { ...state, error: null, fetching: true, fetched: false };
    case 'GET_BUGS_FULFILLED':
      return {
        ...state,
        bugList: action.payload,
        error: null,
        fetching: false,
        fetched: true,
      };
    case 'CREATE_BUG_FULFILLED':
    case 'DELETE_BUG_FULFILLED':
    case 'UPDATE_BUG_FULFILLED':
      return {
        ...state,
        bugList: action.payload.all.bugs,
        perosnalBugList: action.payload.personal.bugs,
        error: null,
        fetching: false,
        fetched: true,
      };
    case 'GET_PERSONAL_BUGS_FULFILLED':
      return {
        ...state,
        perosnalBugList: action.payload,
        error: null,
        fetching: false,
        fetched: true,
      };
    case 'SOLVE_BUG_FULFILLED':
      return {
        ...state,
        bugList: action.payload.bugs,
        error: null,
        fetching: false,
        fetched: true,
      };
    case 'GET_BUGS_REJECTED':
    case 'CREATE_BUG_REJECTED':
    case 'DELETE_BUG_REJECTED':
    case 'UPDATE_BUG_REJECTED':
    case 'SOLVE_BUG_REJECTED':
    case 'GET_PERSONAL_BUGS_REJECTED':
      return {
        ...state,
        error: action.payload,
        fetching: false,
        fetched: false,
      };
    default:
      return { ...state };
  }
}
