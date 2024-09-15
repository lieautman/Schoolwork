import {EventEmitter} from 'fbemitter';
import { SERVER_GLOBAL } from '../../Configs/globals';
const SERVER = SERVER_GLOBAL+'/user'

class User{
    //starea initiala
    constructor(){
        this.data=[]
        this.emitter=new EventEmitter()
    }

    //metoda de luat date despre toti clientii
    async getAll(){
        try{
            const response = await fetch(`${SERVER}/getAll`)
            if(!response.ok){
                throw response
            }
            this.data=await response.json()
            this.emitter.emit('GETALL_SUCCESS')
        }
        catch(err){
            console.warn(err)
            this.emitter.emit('GETALL_ERROR')
        }
    }

    //metoda de login
    async Login(username,password){
        try{
            const response = await fetch(`${SERVER}/login`,{
                method:'POST',
                headers:{
                    'Content-Type':'application/json'
                },
                body: JSON.stringify({username:username,password:password})
            })
            if(!response.ok){
                throw response
            }
            this.data=await response.json()
            this.emitter.emit('LOGIN_SUCCESS')
        }
        catch(err){
            this.emitter.emit('LOGIN_ERROR',await err.json())
        }
    }
}
const store = new User()

export default store 