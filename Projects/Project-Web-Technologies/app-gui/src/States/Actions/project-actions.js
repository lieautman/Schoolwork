import {SERVER_GLOBAL}from'../../Configs/globals'
const SERVER = SERVER_GLOBAL+'/project'


export const GET_PROJECTS = 'GET_PROJECTS'
export const GET_PERSONAL_PROJECTS = 'GET_PERSONAL_PROJECTS'
export const CREATE_PROJECT = 'CREATE_PROJECT'
export const DELETE_PROJECT = 'DELETE_PROJECT'
export const UPDATE_PROJECT = 'UPDATE_PROJECT'

export function getProjects(){
    return{
        type:GET_PROJECTS,
        payload:async()=>{
            const response = await fetch(`${SERVER}/all`)
            const data= await response.json()
            return data.projects
        }
    }
}
export function getPersonalProjects(type,token){
    return{
        type:GET_PERSONAL_PROJECTS,
        payload:async()=>{
            const response = await fetch(`${SERVER}/${type}/all`,{
                method:'post',
                headers:{
                    'Content-Type':'application/json'
                },
                body:JSON.stringify({token:token})
            })
            const data= await response.json()
            return data.projects
        }
    }
}
export function createProject(linkRepo,nume,idMembruProiect,type,token){
    return{
        type:CREATE_PROJECT,
        payload:async()=>{
            let response = await fetch(`${SERVER}/${type}/create`,{
                method:'post',
                headers:{
                    'Content-Type':'application/json'
                },
                body:JSON.stringify({linkRepo:linkRepo,nume:nume,idMembruProiect:idMembruProiect,token:token})
            })
            let data={all:[],personal:[]}
            response=await fetch(`${SERVER}/all`)
            data.all= await response.json()
            response=await fetch(`${SERVER}/${type}/all`,{
                method:'post',
                headers:{
                    'Content-Type':'application/json'
                },
                body:JSON.stringify({token:token})
            })
            data.personal= await response.json()
            return data
        }
    }
}
export function deleteProject(id,type,token){
    return{
        type:DELETE_PROJECT,
        payload:async()=>{
            let response = await fetch(`${SERVER}/${type}/delete/${id}`,{
                method:'delete',
                headers:{
                    'Content-Type':'application/json'
                },
                body:JSON.stringify({token:token})
            })
            let data={all:[],personal:[]}
            response=await fetch(`${SERVER}/all`)
            data.all= await response.json()
            response=await fetch(`${SERVER}/${type}/all`,{
                method:'post',
                headers:{
                    'Content-Type':'application/json'
                },
                body:JSON.stringify({token:token})
            })
            data.personal= await response.json()
            return data
        }
    }
}
export function updateProject(id,linkRepo,nume,idMembruProiect,type,token){
    return{
        type:UPDATE_PROJECT,
        payload:async()=>{
            let response = await fetch(`${SERVER}/${type}/update/${id}`,{
                method:'put',
                headers:{
                    'Content-Type':'application/json'
                },
                body:JSON.stringify({linkRepo:linkRepo,nume:nume,idMembruProiect:idMembruProiect,token:token})
            })
            let data={all:[],personal:[]}
            response=await fetch(`${SERVER}/all`)
            data.all= await response.json()
            response=await fetch(`${SERVER}/${type}/all`,{
                method:'post',
                headers:{
                    'Content-Type':'application/json'
                },
                body:JSON.stringify({token:token})
            })
            data.personal= await response.json()
            return data
        }
    }
}