const INITIAL_STATE = {
    spacecraftList: [],
    error: null,
    fetching: false,
    fetched: false,
  };
  export default function reducer(state = INITIAL_STATE, action) {
    switch (action.type) {
        case 'GET_SPACECRAFT_PENDING':
        case 'POST_SPACECRAFT_PENDING':
        case 'DESTROY_SPACECRAFT_PENDING':
        case 'PUT_SPACECRAFT_PENDING':
        case 'EXPORT_PENDING':
        case 'IMPORT_PENDING':
          return{...state,error:null,fetching:true,fetched:false}
        case 'GET_SPACECRAFT_FULFILLED':
          return{...state,spacecraftList:action.payload,error:null,fetching:false,fetched:true}
        case 'POST_SPACECRAFT_FULFILLED':
          return{...state,spacecraftList:action.payload.spacecraftList,error:action.payload.message,fetching:false,fetched:true}
        case 'DESTROY_SPACECRAFT_FULFILLED':
          return{...state,spacecraftList:action.payload.spacecraftList,error:action.payload.message,fetching:false,fetched:true}
        case 'PUT_SPACECRAFT_FULFILLED':
          return{...state,spacecraftList:action.payload.spacecraftList,error:action.payload.message,fetching:false,fetched:true}
        case 'EXPORT_FULFILLED':
        case 'IMPORT_FULFILLED':
          return{...state}
        case 'GET_SPACECRAFT_REJECTED':
        case 'POST_SPACECRAFT_REJECTED':
        case 'DESTROY_SPACECRAFT_REJECTED':
        case 'PUT_SPACECRAFT_REJECTED':
        case 'EXPORT_REJECTED':
        case 'IMPORT_REJECTED':
          return{...state,error:action.payload,fetching:false,fetched:false}
        default:
            return{...state}
    }
}