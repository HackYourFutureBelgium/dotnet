import React, { Fragment, useState } from "react";
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import { useAuth0, withAuthenticationRequired } from "@auth0/auth0-react";
import Loading from "../components/Loading";

const Functionality = () => {
    const {
        getAccessTokenSilently
    } = useAuth0();

    const [description, setDescription] = useState('');
    const [id, setId] = useState('');
    const [idToRemove, setIdToRemove] = useState('');
    const [descriptionFromTodo, setDescriptionFromTodo] = useState('');

    const handleChange = event => {
        setDescription(event.target.value);
    };

    const handleIdChange = event => {
        setId(event.target.value);
    };

    const handleIdToRemoveChange = event => {
        setIdToRemove(event.target.value);
    };

    const createTodoItem = async () => {
        try {
            const token = await getAccessTokenSilently();

            await fetch(`https://localhost:7225/api/Todo?description=${description}`, {
                headers: {
                    Authorization: `Bearer ${token}`,
                    'Content-Type': 'application/json'
                },
                method: 'POST'
            })
                .then(response => response.json())
                .then(data => setId(data.id));

        } catch (error) {
            console.log(error);
        }
    }

    const getTodoItemDescription = async () => {
        try {
            const token = await getAccessTokenSilently();

            await fetch(`https://localhost:7225/api/Todo?id=${id}`, {
                headers: {
                    Authorization: `Bearer ${token}`,
                    'Content-Type': 'application/json'
                },
                method: 'GET'
            })
                .then(response => response.json())
                .then(data => setDescriptionFromTodo(data.description));

        } catch (error) {
            console.log(error);
        }
    }

    const removeTodoItem = async () => {
        try {
            const token = await getAccessTokenSilently();

            await fetch(`https://localhost:7225/api/Todo?id=${idToRemove}`, {
                headers: {
                    Authorization: `Bearer ${token}`,
                    'Content-Type': 'application/json'
                },
                method: 'DELETE'
            });

        } catch (error) {
            console.log(error);
        }
    }

    return (
        <Fragment>
            <p>Post description</p>
            <TextField id="Description" label="Description" variant="outlined" onChange={handleChange} />
            <br /><br />
            <Button variant="contained" onClick={() => createTodoItem()}>Create todo-item</Button>
            <hr />
            <p>ID of created todo-item</p>
            <TextField id="IdCreated" label="ID" variant="outlined" value={id} onChange={handleIdChange} />
            <br /><br />
            <Button variant="contained" onClick={() => getTodoItemDescription()}>Get description</Button>
            <br /><br />
            <TextField id="DescriptionGot" label="Description from todo" variant="outlined" value={descriptionFromTodo} />
            <hr />
            <TextField id="IdToRemove" label="ID" variant="outlined" onChange={handleIdToRemoveChange} />
            <br /><br />
            <Button variant="contained" onClick={() => removeTodoItem()}>Remove todo-item</Button>
        </Fragment>
    );
};

export default withAuthenticationRequired(Functionality, {
    onRedirecting: () => <Loading />,
});
