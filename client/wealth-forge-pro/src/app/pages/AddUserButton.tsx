import React from 'react';
import { Button } from '@/components/ui/button';

interface AddUserButtonProps {
  onClick: () => void;
}

const AddUserButton: React.FC<AddUserButtonProps> = ({ onClick }) => {
  return (
    <div style={{ marginBottom: '16px' }}>
      <Button type="submit" onClick={onClick}>
        Add User
      </Button>
    </div>
  );
};

export default AddUserButton;
