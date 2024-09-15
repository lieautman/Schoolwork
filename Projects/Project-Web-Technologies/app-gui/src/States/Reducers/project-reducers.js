const INITIAL_STATE={
    projectList:[],
    personalProjectList:[],
    error:null,
    fetching:false,
    fetched:false
}

export default function reducer(state=INITIAL_STATE,action){
    switch(action.type){
        case 'GET_PROJECTS_PENDING':
        case 'CREATE_PROJECT_PENDING':
        case 'DELETE_PROJECT_PENDING':
        case 'UPDATE_PROJECT_PENDING':
        case 'GET_PERSONAL_PROJECTS_PENDING':
            return{...state,error:null,fetching:true,fetched:false}
        case 'GET_PROJECTS_FULFILLED':
            return{...state,projectList:action.payload,error:null,fetching:false,fetched:true}
        case 'CREATE_PROJECT_FULFILLED':
        case 'DELETE_PROJECT_FULFILLED':
        case 'UPDATE_PROJECT_FULFILLED':
            return{...state,projectList:action.payload.all.projects,personalProjectList:action.payload.personal.projects,error:null,fetching:false,fetched:true}
        case 'GET_PERSONAL_PROJECTS_FULFILLED':
            return{...state,personalProjectList:action.payload,error:null,fetching:false,fetched:true}
        case 'GET_PROJECTS_REJECTED':
        case 'CREATE_PROJECT_REJECTED':
        case 'DELETE_PROJECT_REJECTED':
        case 'UPDATE_PROJECT_REJECTED':
        case 'GET_PERSONAL_PROJECTS_REJECTED':
            return{...state,error:action.payload,fetching:false,fetched:false}
        default:
            return {...state}
    }
}