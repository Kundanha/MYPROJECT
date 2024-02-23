"use client"
import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Table, TableBody, TableCaption, TableCell, TableHead, TableHeader, TableRow } from '@/components/ui/table';
import UserForm from '@/app/pages/UserForm';
import UserData from '../models/UserData';
import UserList from './UserList';
import ThemeSwitcher from './ThemeSwitcher';
import AddUserButton from './AddUserButton';
import { Login } from '../login';
const Dashboard: React.FC = () => {
  // State for users data
  const [users, setUsers] = useState<UserData[]>([]);
  // State for modal visibility
  const [isModalVisible, setIsModalVisible] = useState<boolean>(false);
  const [theme, setTheme] = useState<string>('light');
  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get<UserData[]>('https://localhost:7216/api/User');
        setUsers(response.data);
      } catch (error) {
        console.error('Error fetching data:', error);
      }
    };

    fetchData();
  }, []);

  // Function to open modal
  const showModal = () => {
    setIsModalVisible(true);
  };

  // Function to close modal
  const handleCancel = () => {
    setIsModalVisible(false);
  };

  // Function to handle form submission
  const handleFormSubmit = async (formData: UserData) => {
    try {
      const response = await axios.post<UserData>('https://localhost:7216/api/User', formData);
      setUsers([...users, response.data]);
      setIsModalVisible(false); // Close the modal after form submission
    } catch (error) {
      console.error('Error submitting form:', error);
    }
  };

  return (
    <div>
      <div className={'dashboard-container'}>
      <AddUserButton onClick={showModal} />
        <ThemeSwitcher />
      </div>
      <UserList users={users} />
      <UserForm visible={isModalVisible} onCancel={handleCancel} onSubmit={handleFormSubmit}/>
    </div>
  );
};

export default Dashboard;
