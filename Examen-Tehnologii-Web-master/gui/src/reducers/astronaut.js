const INITIAL_STATE = {
    astronautList: [],
    error: null,
    fetching: false,
    fetched: false,
  };
  export default function reducer(state = INITIAL_STATE, action) {
    switch (action.type) {
        case 'GET_ASTROANUT_PENDING':
        case 'POST_ASTROANUT_PENDING':
        case 'PUT_ASTROANUT_PENDING':
        case 'DESTROY_ASTROANUT_PENDING':
          return{...state,error:null,fetching:true,fetched:false}
        case 'GET_ASTROANUT_FULFILLED':
          return{...state,astronautList:action.payload,error:null,fetching:false,fetched:true}
        case 'POST_ASTROANUT_FULFILLED':
        case 'PUT_ASTROANUT_FULFILLED':
        case 'DESTROY_ASTROANUT_FULFILLED':
          return{...state,astronautList:action.payload.astronautList,error:action.payload.message,fetching:false,fetched:true}
        case 'GET_ASTROANUT_REJECTED':
        case 'POST_ASTROANUT_REJECTED':
        case 'PUT_ASTROANUT_REJECTED':
        case 'DESTROY_ASTROANUT_REJECTED':
          return{...state,error:action.payload,fetching:false,fetched:false}
        default:
            return{...state}
    }
}