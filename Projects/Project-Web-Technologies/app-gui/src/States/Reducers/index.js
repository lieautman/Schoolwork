import{combineReducers}from 'redux'

import project from './project-reducers'
import bug from './bug-reducers'
import main from './main-reducers'



export default combineReducers({
    project,
    bug,
    main
})